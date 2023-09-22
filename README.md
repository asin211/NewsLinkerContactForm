# NewsLinkerContactForm
C# Windows Forms Contact Form for NewsLinker
Program Requirements
- It should allow the user to enter name, address, email, phone number and specify the preferred means of contact.
- The preferred means of contact should be set as a radio button alongside email and phone number.
- When one of the radio buttons is unticked, the associated textbox should be grayed out as disabled.
- If the preferred means of contact selected is a phone number, the label listing the phone number of the company’s 
  support line should be displayed. If the preferred means of contact selected is an email, the message stating the 
  team will contact the user within two days should be displayed in a label. Only one label should be visible at a time.
- There should be a menu with menu items to reset the form and exit the application.
- There should be a button to submit the application. When an application is submitted a new customer object should 
  be created and the following properties should be assigned: CustomerID(counter) Name, Address, Email, PhoneNumber, 
  MeansOfContact. The object should then be added to an ArrayList containing all the Customer objects created.
- On another tab include a button that, when clicked, lists all customers’ information from the Customer ArrayList.
- Use appropriate descriptive label(s) for user experience.
- Use comments within the application to provide descriptions for the objects, events and methods.
