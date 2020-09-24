Feature: Language
	As a Seller of this portal I want to manage the "Language" section effectively


@Automate "Add New" Language 

Scenario: A seller can Add New language with valid inputs  
Given I click on LANGUAGE data tab
When  I press ADD NEW button and then I enter Add Language and Level and press Add 
Then I should able to validate added NEW LANGUAGE record Successfully 

@Automate "Update" Language 

Scenario: A seller can  Update   language with new valid inputs  
Given I click on LANGUAGE data tab
When  I press Update pen and Update The  Language and Level and press the UPDTAE button
Then I should able to validate new UPDATED LANGUAGE record Successfully 

@Automate "Delete" Language 

Scenario: A seller can Delete  existing  language   
Given I click on LANGUAGE data tab
When  I press CROSS delete sign
Then I should not be able to see the DELETED LANGUAGE and should receive a Pop up message 


