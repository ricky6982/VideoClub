Feature: AccessToMovies
	Como usuario quiero acceder con mi número de socio al catálogo de películas
	para conocer qué películas puedo alquilar

@mytag
Scenario: Gain access to movies
	Given I am a member of the video club
	When I enter my member number
	Then I am granted access to the system

Scenario: Navigate through movies catalog
	Given I am a member of the video club
	When I select the movies catalogs
	Then I can access all movies paged by 10 movies at a time

#Scenario: Navigate through movies categories
#	Given I am a member of the video club
#	When I select a categories
#	Then I can see all movies from that category paged by 10 items at a time
#	
#Scenario: Navigate through movies by director
#	Given I am a member of the video club
#	When I enter the name of a director
#	Then I can see all movies made by the director paged by 10 items at a time	