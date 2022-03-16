Lesson 2 - https://cityofbristol-my.sharepoint.com/:w:/g/personal/bsmith_cityofbristol_ac_uk/EX6yhuFbJ29Mu9ZgEScV9D4BvwYXBTPhpIeP8upqkmCj-g?e=DcaF9r Add a Login page and navigation to the food ordering page (which we will create in Lesson 3). Overview of what to make: 

Create a github account GitHub (github is like your calling card or CV for developers where you can showcase what you can do and the work you have done or are interested in, you can also find other interesting useful projects other people have made that you may want to develop): https://github.com/  

- Add a login page as page 1 (you need 2 entry fields and button that will login the user in) 

- When login is complete (press the login button) it will navigate to page 2 which will become the food ordering page (develop that in lesson 3) 

- The login will check whether the username and password are correct and provide feedback to the user 

- You need to choose what kind of navigation you want from these examples Hierarchical Navigation - Xamarin | Microsoft Docs 

 

Create a new project and call it Canteen App (or whatever your app is about) 

1. Create a new github account, from now on we are going to use Github to store your work (and for all future projects you code). It is the common platform for developers to keep track of their work and make sure it is saved. https://github.com/  

2. Once you have an account open the github desktop app   that should be installed GitHub Desktop | Simple collaboration from your desktop you need to connect and authenticate the app with your github account. 

Once this is done add your canteen app project as a new repository in github 

  

You will need to select create repository, so that it is initialised as git repository: 

 

Give it a name and a description and make sure you choose a gitignore file for visual studio (this ignores all the auto-generated rubbish that you don’t need to save) 

 

Once you have created it you can then choose publish and this will push your project to your github where it will be saved forever and ever, unless you delete it or the internet ends: 

 

Everytime you make a change to your project (add a comment in one of the files and you will see the change come up) you need to COMMIT that change locally, and then push the change to the remote repository, that way you save your work from being corrupted or lost. 

 

Creating the Login: 

1. Add 2 new pages: OrderPage and a LoginPage by going to Project > Add New Item  

 

So you should have 3 pages: 

 

2.  In your App.xaml.cs you need to change the code to point to your first page in the navigation, replace whatever is in the brackets of new NavigationPage( LoginPage() ) . The App.cs is where your app starts, it is really useful and can do lots of things like save the state of your app etc. But here we are using it to start a hierarhical stack navigation where each page is pushed or popped: 

 

3. Now we can start creating the login page. You need to add 3 components to the Login Page XAML: 2 Entry input boxes Xamarin.Forms Entry - Xamarin | Microsoft Docs ; and a Login button Xamarin.Forms Button - Xamarin | Microsoft Docs . Look at what we did last week to work out how to add these or look up the Xamarin documents. 

4. When creating the button if you start writing the name of the clicked function it will automatically fill it in for you, select the new event handler and it will create the function in the Login.cs : 

5. In your login function write the code to check if the userName is equal to whatever your username is, and if the password is also equal. You need to use and AND  && condition in the IF statement 

If the username and password are correct you need to push the the OrderPage onto the navigation stack to find out how this works read this document: https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/navigation/hierarchical  

6. You need to add this code if the login details are correct, but you will need to push whatever your orderPage is named: 

Navigation.PushAsync (new OrderPage ()); 

7. If you login details are not correct then show an alert to the user! 

EXTRA: Make your login page look better than this... look as close to your design as possible! Once you have finished this you may want to start on your OrderPage so ask me for the next tutorial or look here 

 

 
