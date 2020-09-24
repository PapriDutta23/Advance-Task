Feature: Education
	As a Seller of this portal I want to manage the "Education" section effectively


	@Automate "Add New" Education

Scenario: A seller can  Add New Education with valid inputs  
Given I click on EDUCATION data tab
When  I press ADD NEW button and then I enter College/University Name ,Country of University, Title  , Degree . Year of Graduation and press Add 
Then I should able to validate added NEW EDUCATION record Successfully 

@Automate Update Education

Scenario: A seller can  Update language with new valid inputs  
Given I click on EDUCATION data tab
When  I press Update pen and Update The College/University Name ,Country of University, Title  , Degree . Year of Graduation with new data and press UPDATE button
Then I should able to validate UPDATED EDUCATION Successfully 

@Automate Delete Education

Scenario: A seller can  Delete  existing  Education 
Given I click on EDUCATION data tab
When  I press CROSS delete sign for education
Then I should not be able to see the DELETED EDUCATION and should receive a Pop up message


