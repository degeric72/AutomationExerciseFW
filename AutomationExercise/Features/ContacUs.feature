Feature: ContacUs
	As a user
	I want to be able to work with Contact Us section
	So I can message customer support

@mytag
Scenario: User can send message via contact us form
	Given user opens contact us page
	When user enters all required fields
	And submits contac us form
	And confirm the prompt message 
	Then user will receive 'Succes! Your details have been submitted succesfully.' message
