# 2024 PAW Seminar code samples

Seminar support: https://github.com/liviucotfas/ase-windows-applications-programming

## Test tutoring

- CRUD
- Validation and Error Providers
- Serialization/Deserialization
- Dialog windows

### Subject number: ST01

Duration: 60min, Mandatory: the project should compile and run without any errors.

(1p)

Create a Windows Forms Project with the following name: "SubjectNumber_StudyYear_Group_LastName_FirstName".

For managing a logistics company, you are asked to define two classes: a primary class Truck (with at least 3 different types of attributes) and a secondary class Fleet (which among its properties will include a collection or array of Trucks).

At least one of these classes must include a constructor with parameters.

(2p)

The user should be able to add new instances of the primary class using a secondary form (-75% if you are using the same form). The instances must be stored in the collection included in the secondary class.

(1p)

The instances of the primary class will be displayed using a ListView control configured to look like a table. The user should be able to highlight an entry in the list by clicking anywhere inside the corresponding row.

(1p)

Perform validations on the data inputed by the user in the secondary form. The errors will be displayed using error providers.

(1p)

Add the option to edit the items in the ListView by double clicking on them. Use a secondary form.

(1p)

Implement the IComparable or IComparable<T> interface to compare instances of the primary class based on any criterion of your own choice. Keep the items sorted at all times in the ListView in ascending order based on your chosen criterion.

(2p)

Add a tool bar to the top of the application, allowing the user to serialize and deserialize the instance of the secondary class using any format of your choice (XML, CSV or binary). The user must be able to choose the location of the saved file when serializing and the file from which to restore when deserializing (-25% if path is hardcoded).