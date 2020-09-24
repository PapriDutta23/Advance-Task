Feature: Certification
As a Seller of this portal I want to manage the "Certification" section effectively
	
	

	@Automate "Add New" Certification

Scenario: A seller can  Add  New Certification with valid inputs  
Given I click on CERTIFICATION data tab
When  I press ADD NEW button and then I enter Certificate ,Certificate From,  Year  and press Add 
Then I should able to validate added NEW CERTIFICATION record Successfully 

@Automate Update Certification

Scenario: A seller can  Update  Certifucate with new valid inputs  
Given I click on CERTIFICATION data tab
When  I press Update pen and Update The Certificate ,Certificate From,  Year  and press the UPDATE button
Then I should able to validate UPDATED CERTIFICATION Successfully 

@Automate Delete Certification

Scenario: A seller can  Delete  existing  Education 
Given I click on CERTIFICATION data tab
When  I press CROSS delete sign for Certification
Then I should not be able to see the DELETED CERTIFICATION and should receive a Pop up message 
