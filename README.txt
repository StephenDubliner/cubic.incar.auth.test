Q1:
Essential classes required for the authentication use cases:
HomePage (model)
LoginPage (model)
ResetPasswordPage (model)
PurchaseData (model)
FAQPage (model) 
AssertSteps (flows)
BrowserFactory (selenium factory helper) 

Q2:

Please see implementation starting from LoginPage.

Q3:

Please see implementation starting from AuthenticationTestSuite.

Q4:

I'd recommend building tracing solution on NLog framework defining log targets as required per deployment (local file, database...).
The trace calls should be used in assertion code - sample AssertLoginSuccessful of LoginAsserts class.