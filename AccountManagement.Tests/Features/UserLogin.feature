Feature: User Login To Account

Scenario: User Can Login To Account
	Given i am <username> with password <password>
	And the following users are already available
		| username | password |
		| alireza  | 123      |
	When i try to login
	Then i should get message <result>

	Examples:
		| username | password | result        |
		| alireza  | 123      | Authenticated |
		| hasan    | 32163546 | Access Denied |