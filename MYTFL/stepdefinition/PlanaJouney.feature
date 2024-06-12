Feature: PlanaJouney
	

@mytag
Scenario: Plan a journey
	Given Tfl homepage has been open
	And accepts cookies
	When a user inputs the from box with "Kent"
	And a user wait until the location pops up
	And the user clicks on kent
	And the user inputs "wool" in the to box
	And the user waits until woolwich road pops up
	And the user clicks on woolwich road
	And the user clicks on time change
	And the user selects day drop down
	And user  clicks "20240614"
	And user  select timedropdown
	And user clicks "0115"
	And usr clicks on plan my journey
	Then the Journey is planned based on transport means