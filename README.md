# check-empty-collection-vb

This is for Blue Prism Global Code.
External Reference:
System.Data.dll

Namespace Imports
System.Data
System.Collections.Generic

The CheckCollectionEmpty class is defined, which contains a shared function named IsCollectionEmpty.  
The IsCollectionEmpty function takes a DataTable object as its argument and returns a Boolean value indicating whether the table is empty or not.  
The function uses the Rows property of the DataTable object to get the number of rows in the table, and checks if it's equal to 0. 
If it is, the function returns True, indicating that the table is empty. Otherwise, it returns False, indicating that the table is not empty.  
Finally, a DataTable object is created and passed to the IsCollectionEmpty function. The result of the function is stored in a Boolean variable named isEmpty. 
An If statement is then used to check the value of isEmpty, and write an appropriate message to the console. 
If isEmpty is True, the message "The table is empty." is written. If isEmpty is False, the message "The table is not empty." is written.
