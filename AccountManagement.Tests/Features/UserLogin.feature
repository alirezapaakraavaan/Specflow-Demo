Feature: User Login To Account

Scenario: User Can Login To Account
	Given i am 'alireza' with password '123'
	When i try to login
	Then i should get message 'Authenticated'