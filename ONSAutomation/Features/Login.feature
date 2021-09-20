Feature: Login
	Simple calculator for adding two numbers

@mytag @login @regression
Scenario: Login test
	Given I am on the login page "https://ons-stag.spacenextdoor.com/login"
	And I click mail input field
	And I enter mail
	And I click sent otp button
	#And I insert otp ""
	#And I click login button
	#And I click choose company 
	#And I choose snd company
 #   When I Click save company button
	#Then Url should be "https://ons-stag.spacenextdoor.com/login"