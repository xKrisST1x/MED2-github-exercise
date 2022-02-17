# MED2 GitHub Exercises

Before the exercise, please make sure that you have installed Unity version 2020.3.28f1, [GitHub Desktop](https://desktop.github.com), and a source-code editor (such as Visual Studio Code). Also make sure that you have created a GitHub account on www.github.com.

### 1. Fork and clone repository
- Go together in groups of two. Remember to work together and communicate even though some tasks only require one computer.
- **One** person from the group should:
  - Fork this GitHub repository by pressing <img src="https://github.com/malteerasmussen/MED2-github-exercise/blob/main/Fork%20button.png" height="25"> in the top right corner. This will create a forked (a copy) repository. 
  The forked repository will be called "[your github username]/MED2-github-exercise".
  - Add the other group member to the forked repository (the one you just created) by going to Settings > Collaborators > Add people.
- The **other** group member then receives an invitation by email and should:
  - Accept the invitation to join the repository.
- **Both** group members should then:
  - Clone the repository by pressing <img src="https://github.com/malteerasmussen/MED2-github-exercise/blob/main/Code%20button.png" height="25"> and then "Open with GitHub Desktop". If you get a pop-up asking "How are you planning to use this fork?" you should choose "For my own purposes."

### 2. Pull and push
- Open the Unity project "GitHub Unity Exercise" located in your local repository.
- Open "SampleScene".
- Locate and open the script "ExerciseCode.cs".
- On **one** computer, edit the code to add the function call "<em>PassByValue(myVariable);</em>" on line 14, as indicated in the code. Save and press play in Unity to observe the result in the console.
- Go back to GitHub Desktop. Here you can now see the changes you have made. Write a summary of the change and press "Commit to main". Upload your local changes by pressing the "Push" button at the top.
- Now, on the **other** computer, go to GitHub Desktop and press "Fetch" at the top. Then press "Pull". This fetches and downloads the content on the remote repository and updates your local repository to match the content. Go to the Unity project and open the "ExerciseCode.cs" script to see that you now have the updated code.

### 3. Merge conflicts
- On **both** computers, change the function call on line 14 to "<em>PassByReference(ref myVariable);</em>". Save and press play in Unity to observe the result in the console.
- On **one** computer, also add a comment after the function call **on line 14**, which explains the code.
- On **both** copmuters, go back to GitHub Desktop, commit your changes, and push them.
- The second one to push will have to take some extra steps; GitHub will prompt them to fetch and pull the other one's changes. This will resolve in a merge conflict. Open the conflicted file to see the conflict.
- To resolve the conflict, you must choose to use either your changes or the other one's changes. Do this in GitHub Desktop by pressing the button indicated in the image below. "main" is your own changes; "origin/main" is the other one's changes.
<img src="https://github.com/malteerasmussen/MED2-github-exercise/blob/main/merge%20conflict.png" height="300">


---
If you want to learn more, you might want take a look at this [GitHub Desktop Guide](https://docs.github.com/en/desktop/installing-and-configuring-github-desktop/overview/creating-your-first-repository-using-github-desktop).
