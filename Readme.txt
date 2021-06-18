The following solution was designed with OOP principles in mind and some of the SOLID principles to avoid
code duplication and achieve a loosely coupled structure.

=====Sales-Taxes.Logic=====
This is the core business logic of the application, here we have defined components such as the ticket printer
and the taxes calculator which are the responsibles of executing tasks like print the ticked in the specified
format or to calculate the total taxes of the selected items.

- ITaxesCalculator: Interface that defines the funcionality of a class that implements the taxes calculator functions.
- ITicketPrinter: Interface that defines the funcionality of a class that prints a ticket in a specified format

Note: Interfaces were created to provide loose couplinig with store class, so if in the future another type of printer
is desired to be implemented it can be done by inheriting from the ITicketPrinter.

- Store: This class uses composition containing an ITicketPrinter and ITaxesCalulator and encapsultaes both classes
instanciation inside it's own constructor, as you will apreciate the store is the responsible to set the sales taxes 
and import taxes rate, not the taxes calculator as this is just a device to get the calculation of taxes. 
Once the store is instanciated a ticker printer and taxes calculator are instanciated as well inside the sore constructor
so now we can access their funtionality.

TaxesCalculator & TicketPrinter: These are the implementation from ITicketPrinter and ITaxesCalculator.

=====Sales-Taxes.MockData=====
This static class sole purpose is to serve as an In-memory data of the items 
available to purchase in the store (Store Catalog).


=====Sales-Taxes=====
This is the presentation layer which displays the store menu and accepts the user input to selec the items to purchase,
display alerts and finaly get the printed ticket for the customers purchase.

- ConsoleUtil: A statis class to provide common console tasks used repeatedly in the interaction with the user, for example
console clear function or printing alert messages when performing certain operations.

- Storeview: The main view, responsible to display the store menu and to recieve customer input. It consume the
Sales-Taxes.MockData to get the in-memory store catalog and the Sales-Taxes.Logic to process the user input to return
to the customer the ticket for his purchase with the sales taxes and the total of thr purchase.