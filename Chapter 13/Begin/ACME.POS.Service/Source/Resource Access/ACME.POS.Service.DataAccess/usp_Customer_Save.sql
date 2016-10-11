
IF NOT EXISTS (SELECT NAME FROM sys.objects WHERE TYPE = 'P' AND NAME = 'RethrowError')
BEGIN
	EXEC('CREATE PROCEDURE [dbo].RethrowError AS RETURN')
END
GO

ALTER PROCEDURE RethrowError AS
    /* Return if there is no error information to retrieve. */
    IF ERROR_NUMBER() IS NULL
        RETURN;

    DECLARE
        @ErrorMessage    NVARCHAR(4000),
        @ErrorNumber     INT,
        @ErrorSeverity   INT,
        @ErrorState      INT,
        @ErrorLine       INT,
        @ErrorProcedure  NVARCHAR(200); 

    /* Assign variables to error-handling functions that
       capture information for RAISERROR. */

    SELECT
        @ErrorNumber = ERROR_NUMBER(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE(),
        @ErrorLine = ERROR_LINE(),
        @ErrorProcedure = ISNULL(ERROR_PROCEDURE(), '-'); 

    /* Building the message string that will contain original
       error information. */

    SELECT @ErrorMessage = 
        N'Error %d, Level %d, State %d, Procedure %s, Line %d, ' + 
         'Message: '+ ERROR_MESSAGE(); 

    /* Raise an error: msg_str parameter of RAISERROR will contain
	   the original error information. */

    RAISERROR(@ErrorMessage, @ErrorSeverity, 1,
        @ErrorNumber,    /* parameter: original error number. */
        @ErrorSeverity,  /* parameter: original error severity. */
        @ErrorState,     /* parameter: original error state. */
        @ErrorProcedure, /* parameter: original error procedure name. */
        @ErrorLine       /* parameter: original error line number. */
        );

GO

----------------------------------------------------------------
-- [dbo].[Customer] Table
--
IF NOT EXISTS (SELECT NAME FROM sys.objects WHERE TYPE = 'P' AND NAME = 'usp_Customer_Save')
BEGIN
	EXEC('CREATE PROCEDURE [dbo].[usp_Customer_Save] AS RETURN')
END

GO

ALTER PROCEDURE [dbo].[usp_Customer_Save]
    @birthDate datetime,
	@customerId int OUT,
	@firstName varchar(50),
	@isActive bit = 1,
	@lastName varchar(50),
	@memberSince datetime
AS
BEGIN
	SET NOCOUNT ON
	
	BEGIN TRY
	
	IF(EXISTS(SELECT * FROM [dbo].[Customer] WHERE [CustomerId]=@customerId))
	BEGIN
		UPDATE [dbo].[Customer] 
		SET [BirthDate] = @birthDate, [FirstName] = @firstName, [IsActive] = @isActive, [LastName] = @lastName, [MemberSince] = @memberSince
		WHERE [CustomerId]=@customerId

		IF @@ROWCOUNT = 0
		BEGIN
			RAISERROR('Concurrent update error. Updated aborted.', 16, 2)
		END
	END
	ELSE
	BEGIN
		INSERT INTO [dbo].[Customer] ([BirthDate], [FirstName], [IsActive], [LastName], [MemberSince])
		VALUES (@birthDate, @firstName, @isActive, @lastName, @memberSince)
		SET @customerId = SCOPE_IDENTITY()
	END
	
    END TRY

    BEGIN CATCH
		EXEC RethrowError;
	END CATCH
    
    SET NOCOUNT OFF
END    

GO

