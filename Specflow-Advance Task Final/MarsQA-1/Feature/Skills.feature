Feature: Skills
	As a Seller of this portal I want to manage the "SKILLS" section effectively


	@Automate "Add New" Skills

Scenario: A seller can  Add  New Skills with valid inputs  
Given I click on SKILLS data tab
When  I press ADD NEW button and then I enter Add Skills and Level and press Add 
Then I should able to validate added NEW SKILLS record Successfully 

@Automate Update SKILLS

Scenario: A seller can  Update   Skill with new valid inputs  
Given  I click on SKILLS data tab
When  I press Update pen and Update The  SKILLS  and LEVEL and Press the UPDATE button
Then I should able to validate new UPDATED SKILLS  record Successfully 

@Automate Delete SKILLS
Scenario: A seller can  Delete  existing  Skill
Given I click on SKILLS data tab
When  I press CROSS delete sign for Skills
Then I should not be able to see the DELETED SKILLS and should receive a Pop up message


