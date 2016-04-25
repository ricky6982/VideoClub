Feature: ControlUserRegister
	In order to add a new user 
	And obtain an socio's number for rent a movie

@mytag
Scenario: Valid new member
	Given I am not a member of a video club
	And I enter "Maxi" as the name
	And I enter "Topp" as the lastname
	When I click Register Me
	Then a member number is given to me

Scenario: Member already exists 
	Given I am a member of a video club
	And I enter "Maxi" as the name
	And I enter "Topp" as the lastname
	When I click Register Me
	Then a message is shown telling me that I'm allready a member of the club
