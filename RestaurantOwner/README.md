# Restaurant Owner App


Scenario:

        Restaurant owners want to buy multiple refrigerators in order to store large quantities of food
    and serve as many customers as possible. Restaurant owners have difficulty keeping track of their stock and are asking you for your
    help. They task you with creating a application that they can use to organize and keep track of their stored food.


Requirements:

    - The application should interact with the account user through the console.

    - The user should be able to decide which task they’d like to perform. When the user has
      completed a task the application’s event loop should give the user the option of
      performing a new task. “Logout” and/or “Exit” should be an option.

    - All information should be persisted (saved) using serialization and text files. This step
      allows you to RESTART your application and STILL see all changes made in the
      previous run of the application.

Restaurant accounts:

    - As a restaurant, you should be able to register a new RESTAURANT account with a
      username and password.
    
    - As a restaurant, you should be able to add refrigerators to your account. You should
      be able to add new or remove refrigerators at any time. If you delete a fridge the food
      from that fridge is placed into another fridge (you may not delete your LAST fridge).
            ○ Fridges may only hold a maximum of FIVE food items.
            ○ Each fridge object should remember which restaurant purchased it.

    - As a restaurant, you should be able to deposit food into a fridge. This will more than
      likely require the user to use the console to type in a new food item.
            ● As a restaurant, you should be able to withdraw food from a fridge.
            ● As a restaurant, you should be able to transfer food between fridges (restaurants may
              have 1 or more fridges).    