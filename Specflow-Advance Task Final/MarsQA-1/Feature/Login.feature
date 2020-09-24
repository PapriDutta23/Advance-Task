Feature: Login
	Verify If Login functionality works properly

@mytag
Scenario:Login to the portal as a User with Valid credentials
Given I naviagte to the Skill Swap Website
And I have entered valid Username and password 
When  I press login Button
Then I should be navigated to My Profile page and can see my Name