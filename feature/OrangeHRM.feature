Feature: Manager user
	As a admin
	I want to be create and edit user
	
@mytag
Scenario: Successful Login with Valid Credentials
	Given Orange page url
	When User enter <username> and <password>
	And Click on the LogIn button
	Then Successful Login and Dashboard page should get displayed
Examples: 
	| username | password |
	| Admin    | admin123 |

@mytag
Scenario: Un Successful Login with inValid Credentials
	Given Orange page url
	When User enter <username> and <password>
	And Click on the LogIn button
	Then Un Successful Login message should display
Examples: 
	| username | password |
	| Abc	   | 12345    |
   