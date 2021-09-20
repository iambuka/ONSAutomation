Feature: UnitsFeature
	Simple calculator for adding two numbers

@mytag @AddUnitsType @regression
Scenario: Add Units type
	Given I am logged in on "https://ons-stag.spacenextdoor.com" 
	And I click units page
	And I click add units type
	And I click name input field
	And I input "BukaTest" unit name
	And I choose "all" attributes option with mark
	And I click save button
	And I am redirected to "https://ons-stag.spacenextdoor.com/units"
	When I click Add Unit button
    Then Should be unit with name "BukaTest"