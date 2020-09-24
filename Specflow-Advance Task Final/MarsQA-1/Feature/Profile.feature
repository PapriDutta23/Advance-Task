Feature: Add  Profile Details
	As a seller on this portal
	I want to manage my Profile Details effectively

	@AddAvailability 
    Scenario: Add availability
    Given I click on Availabilty button
    When I add availability 
    Then I should be able to read pop up 

	@AddEarnTarget
    Scenario: Add earn target 
	Given I click on earn target button
	When I add earn target 
	Then I should be able to read pop up 

	@AddHours 
    Scenario: Add hours 
	Given I click on Add hours button
	When I add Hours
	Then I should be able to read pop up 

    @ChangePassword
    Scenario: Change password
	Given Click on Change Password button
    When I  provide all  the details
	Then  I should be able to see change password 

	@AddDescription
	Scenario: Add Description upto 600 characters
	Given I click on description
	When I have entered description using characters and click on save button
	Then I should be able to read pop up 

	



