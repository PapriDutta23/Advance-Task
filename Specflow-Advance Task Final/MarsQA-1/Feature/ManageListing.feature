Feature: ManageListing
	As a Skill Trader
  I should be able to Edit , Delete , View of my added Skills in Manage Listing page

@Automate Edit Manage Listing
Scenario: Edit /Update your Added Services in Manage Listing Page
	Given I Click on the   MANAGE LISTING tab on my PROFILE page
	And I click on the PEN like Update/Edit button
	When Add New SHARE SKILL/New SERVICES
	Then I should be able to view the Updated/Edited New services on MANAGE LISTING page


	@Automate Delete Manage Listing
Scenario: Delete your Added Services in Manage Listing Page
	Given I Click on the   MANAGE LISTING tab on my PROFILE page
	And I click on the CROSS like DELETE button
	Then I should be able get the Confirmation Message of deleting the Added Skill
	
	