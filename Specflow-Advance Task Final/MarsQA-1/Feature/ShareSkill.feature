Feature: Share skill
As a Skill Trader
I want to add services to my Profile

@Add Share Skill
Scenario: I want to Add Services as per my skill level 
	Given I click on the SHARE SKILL tab
	When I enter all the fields in the Share Skill according to my Skill level
	And I press the SAVE button
	Then I should be able to have a my newly added skill in Manage Listing Page
	
	