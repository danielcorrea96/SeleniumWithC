# SeleniumWithC

In this repository you will find a basic project with Selenium and C# within the folder /SeleniumAutomationExercise, additionally,
you will find a Postman collection with a small automation of Pet Store with a CRUD in the folder /PetStoreServiceAutomation.

## Installation

Keep in mind that:

- For the project in /PetStoreServiceAutomation, you must have Postman installed and import the attached JSON to execute the automation.
- For the project in /SeleniumAutomationExercise, you must have Visual Studio installed, remember before running it, to clean the solution.

## Usage
- For the project in /PetStoreServiceAutomation, after importing it, you can go to the RUN section and add the number of interactions you want and the delay between requests. 
The functionality of this project is a basic CRUD where it will create a user, then update it, get that updated user, and finally delete it.
Random data generation provided by Postman has been used for these cases. After running it, you can verify the execution in the view results section. 

- For the project in /SeleniumAutomationExercise, we recommend that before running it, verify that your solution is already clean, and also the version of the chrome driver is 123.0.6312.8600,
therefore, verify if the browser version corresponds to it, if not, update it to the version you currently have. Then, you can run the tests. 
 
For this case, you can visit the /Features folder, where you will find the buyProducts.feature file that contains three test scenarios. The first one refers to adding ten products 
from the website and then validating the quantity of the added products and performing the process of removing the products added to the cart. The second and third scenarios correspond
to failed alternate scenarios, both for verifying non-existing product and quantity of products added to the cart.

After running the tests, you can visit the /TestResults folder within the project, which will contain an index file that is self-generated during execution where you can view the execution 
report of the three test scenarios. 

## Credits

Thank you for your help.

## Licencia

Specify the license under which the project is distributed. It is important to ensure that the project is properly licensed to define the terms and conditions of its use.

