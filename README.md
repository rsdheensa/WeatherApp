# WeatherApp
This Weather app is built using the .NET framework.
The app allows users to check the weather real time for any city, and also allows them to create their account.

Instructions:
1. Open visual studio
2. Choose the option "clone a repository"
3. Type in the URL https://github.com/rsdheensa/WeatherApp.git into repository location
4. Click on clone and wait for the project to load.
5. Under the solution Explorer tab, click on WeatherApp, Source, and then double click WeatherApp.sln. 
6. This will load the project, might take a minute or two
7. On the toolbar, press the green play button next to https.
8. This will build the code and launch the website.

If you get any SSL errors, then change the git settings as follows:

1. Close Visual studio
2. Open CMD as admin
2. Fix 1: type "git config --global http.sslBackend schannel"
3. Open visual studio, and retry cloning the repo.
4. If this still fails, then repeat steps 1 & 2.
5. Fix 2: type "git config --system http.sslBackend schannel"
6. Open visual studio, and retry cloning the repo.
