## Bicycle workshop application
Simple application for managing orders in a bicycle workshop. 
<br/>
<br/>

### Application consist of:

### Main window in two configurations:
#### Listing active tasks
 ![Main form with active tasks](PreviewImages/MainForm.png)


#### Listing finished tasks
 ![Main form with finished tasks](PreviewImages/MainForm-History.png)

 
In those windows, the user can see basic information of active and finished tasks. On the side are located navigation buttons. 

  **With them user can:**
- Add new task
- Manage selected task
  - in active tasks configuration - finishing tasks
  - in history configuration - deleting tasks
- Finish selected task
- Switch between viewing historical and active tasks

#### While deleting task from history user will be prompted to confirm his action
 ![Prompt while removing task](PreviewImages/DeletingHistoricalTask.png)
 
<br/>
<br/>

### Adding task window:
 ![Adding task window](PreviewImages/AddingTask.png)
 
 #### Mandatory fields:
 - Phone number
 - Bicycle manufacturer
 - Bicycle model
 - Date of admission
 - Task description
 
 #### Optional fields:
 - First name of customer
 - Last name of customer
 - e-mail of customer
 - Bicycle frame number
 - Additional informations about bicycle
 - Estimated date of task completion
 - Estimated cost of task
 
 By default date of admission and estimated date of  task completion are locked. To unlock them user has to check checkboxes under label (admission) or inside field (completion).
 If the user does not enable date fields their values will be:
  - Current day for admission date
  - Empty for date of completion

User also has possibility to chose the starting state of the task.
<br/>
<br/>
<br/>

### Editing task window:
 ![Editing task window](PreviewImages/EditingTask.png)
   
This window is mostly the same as adding task window but allow user to edit selected task.
<br/>
<br/>
<br/>

## Bicycle workshop API
Project has been extended with API for managing tasks in workshop. Documentation available in Swagger UI after starting the project.
### Swagger UI of API:
 ![Swagger UI of API](PreviewImages/API.png)

## Configuration
Application requires database connection to work properly. Application will automaticaly create database and seed it with default tasks statuses.
<br/>
<br/>
Application requires connection string in `App.config` to work properly
<br/>
<pre lang="xml">
&ltconnectionStrings&gt
    &ltadd name="WorkshopDB" connectionString="YOUR CONNECTION STRING" providerName="System.Data.SqlClient"/&gt
&lt/connectionStrings&gt
</pre>
<br/>

By default:
<br/>
<pre lang="xml">
&ltconnectionStrings&gt
    &ltadd name="WorkshopDB" connectionString="Data Source=.;Initial Catalog=WorkshopDB;Integrated Security=True;" providerName="System.Data.SqlClient" /&gt
&lt/connectionStrings&gt
</pre>
