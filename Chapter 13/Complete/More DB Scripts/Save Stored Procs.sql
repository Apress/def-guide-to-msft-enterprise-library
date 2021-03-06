-- ================================================
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Keenan Newton
-- Create date: 5/6/2007
-- Description:	Saves BillingMethods
-- =============================================
CREATE PROCEDURE usp_BillingMethod_Save
	-- Add the parameters for the stored procedure here
	@BillingMethodId int out, 
	@PaymentMethodId int,
	@CreditCardNumber varchar(25),
	@CreditCardExpiration DateTime,
	@CreditCardBillingAddressId int,
	@NetTermDays int,
	@IsActive bit,
	@CustomerId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON

    IF(EXISTS(SELECT * FROM [dbo].[BillingMethod] WHERE [BillingMethodId]=@BillingMethodId))
	BEGIN
		UPDATE [dbo].[BillingMethod] 
		SET [PaymentMethodId] = @PaymentMethodId, [CreditCardNumber] = @CreditCardNumber, 
			[IsActive] = @isActive, [CreditCardExpiration] = @CreditCardExpiration, 
			[CreditCardBillingAddressId] = @CreditCardBillingAddressId, 
			[NetTermDays] = @NetTermDays, [CustomerId] = @customerId
		WHERE [BillingMethodId]=@BillingMethodId
	END
	ELSE
	BEGIN
		INSERT INTO [dbo].[BillingMethod] ([PaymentMethodId], [CreditCardNumber], [CreditCardExpiration], 
			[CreditCardBillingAddressId], [NetTermDays],	[CustomerId], [IsActive])
		VALUES (@PaymentMethodId, @CreditCardNumber, @CreditCardExpiration, 
			@CreditCardBillingAddressId, @NetTermDays, @CustomerId, @IsActive)

		SET @BillingMethodId = SCOPE_IDENTITY()
	END
	
	SET NOCOUNT OFF
END
GO

-- ================================================
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Keenan Newton
-- Create date: 5/6/2007
-- Description:	Saves Addresses
-- =============================================
CREATE PROCEDURE usp_Address_Save
	-- Add the parameters for the stored procedure here
	@AddressId int out, 
	@Address varchar(100),
	@City varchar(50),
	@State varchar(2),
	@ZipCode varchar(11),
	@IsPrimaryShipping bit,
	@IsActive bit,
	@CustomerId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON

    IF(EXISTS(SELECT * FROM [dbo].[Address] WHERE [AddressId]=@addressId))
	BEGIN
		UPDATE [dbo].[Address] 
		SET [Address] = @Address, [City] = @City, [IsActive] = @isActive, 
			[State] = @State, [ZipCode] = @ZipCode, [IsPrimaryShipping] = @IsPrimaryShipping,
			[CustomerId]=@customerId
		WHERE [AddressId]=@AddressId
	END
	ELSE
	BEGIN
		INSERT INTO [dbo].[Address] ([Address], [City], [State], [ZipCode], [IsPrimaryShipping],
			[CustomerId], [IsActive])
		VALUES (@Address, @City, @State, @ZipCode, @IsPrimaryShipping, @CustomerId, @IsActive)
		SET @AddressId = SCOPE_IDENTITY()
	END
	
	SET NOCOUNT OFF
END
GO