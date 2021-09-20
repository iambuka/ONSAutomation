Feature: Buildings
	Simple calculator for adding two numbers

@mytag @addBuildings @regression
Scenario: Add building
	Given I am on the login page "https://ons-stag.spacenextdoor.com/login"
    And I click mail input field
	And I enter mail
	And I click sent otp button
	And I Click Add building button
	And I Insert Building name in Building name field 
    And I Insert Contact name in Contact name field 
    And I Insert Contact number in Contact Number field 
    And I Insert Street Adress in Street Adress field 
    And I Insert Zip Code in Zip Code field 
    And I Select City from City drop down list "Singapore"
    And I Select Country from Country drop down list "Singapore"
    And I Select Status from Listing Status drop down list "Active"
    And I Insert Floorname 
    And I insert Floor Level 
    And I Click Save Button
    When I validate current url is changed to "https://ons-stag.spacenextdoor.com/buildings/new-building"
	Then I validate building Building name is added


    @mytag @editBuilding @regression
    Given I am on the login page "https://ons-stag.spacenextdoor.com/login"
    And I click mail input field    
    And I enter mail
    And I click sent otp button

