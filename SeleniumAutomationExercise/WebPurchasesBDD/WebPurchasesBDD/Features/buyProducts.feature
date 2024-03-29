Feature: buyProducts
I as a user of the application
Want to purchases several products
To get the products i want

@purchaseTenProducts @success
Scenario: Purchase 10 items in the application with any product category
	Given the user tries to open the application
	When to purchase products
	| category | subcategory | brand       | nameOfProduct                  |
	| Women    | Tops        | Madame      | Stylish Dress                  |
	| Men      | Jeans       | H&M         | Regular Fit Straight Jeans     |
	| Women    | Dress       | Madame      | Sleeveless Dress               |
	| Women    | Dress       | Madame      | Madame Top For Women           |
	| Kids     | Dress       | Kookie Kids | Full Sleeves Top Cherry - Pink |
	| Kids     | Dress       | Kookie Kids | Little Girls Mr. Panda Shirt   |
	| Kids     | Dress       | Kookie Kids | Cotton Mull Embroidered Dress  |
	| Men      | Tshirts     | H&M         | Men Tshirt                     |
	| Women    | Tops        | Madame      | Stylish Dress                  |
	| Men      | Tshirts     | H&M         | Pure Cotton V-Neck T-Shirt     |
	Then the user should see that 10 have been added to the cart with their total price
	And then he should delete from the added products to validate the empty cart

	@alternativeFlow @failed
	Scenario: Purchase non-existent item
	Given the user tries to open the application
	When to purchase products
	| category | subcategory | brand  | nameOfProduct |
	| Women    | Dress       | Madame | Non-existent  |
	Then the user should see that 6 have been added to the cart with their total price
	And then he should delete from the added products to validate the empty cart


	@alternativeFlow @failed
	Scenario: Purchase 5 items in the application with any product category but validate that there are 6 items in the cart
	Given the user tries to open the application
	When to purchase products
	| category | subcategory | brand       | nameOfProduct                  |
	| Women    | Dress       | Madame      | Madame Top For Women           |
	| Kids     | Dress       | Kookie Kids | Full Sleeves Top Cherry - Pink |
	| Kids     | Dress       | Kookie Kids | Little Girls Mr. Panda Shirt   |
	| Kids     | Dress       | Kookie Kids | Cotton Mull Embroidered Dress  |
	| Men      | Tshirts     | H&M         | Men Tshirt                     |
	Then the user should see that 6 have been added to the cart with their total price
	And then he should delete from the added products to validate the empty cart
