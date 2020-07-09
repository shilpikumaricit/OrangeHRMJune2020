Feature: Manager user
	As a admin
	I want to be create and edit user
	
@mytag
Scenario: Successful Login with Valid Credentials
	Given User is at the Home Page
	And Navigate to LogIn Page
	When User enter <username> and <password>
	And Click on the LogIn button
	Then Successful LogIN message should display