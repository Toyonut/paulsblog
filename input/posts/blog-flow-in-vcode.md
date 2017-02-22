Title: Blogging flow in VS Code
Published: 22/02/2017
Tags: 
    - Cake
    - Wyam
    - VSCode
---
### Blogging flow in VS Code.

<p>How to write a blog like it is the early 2000's... but better.</p>

I use two extensions for writing my blog in VS Code. <br>
The first is the [Cake VSCode Plugin](https://marketplace.visualstudio.com/items?itemName=cake-build.cake-vscode). [On Github](https://github.com/cake-build/cake-vscode). <br>
The second is the [Cake Runner Plugin](https://marketplace.visualstudio.com/items?itemName=wk-j.cake-runner). [On Github](https://github.com/wk-j/vscode-cake-runner). <br>
<br>
The official Cake plugin is good as you get syntax highlighting and bootstrapping for Cake scripts. <br> 
The runner is really cool. You can run all the cake tasks from within Visual Studio Code.<br>
`CTRL + SHIFT + T` launches the plugin options or there is a Cake icon in the bottom bar.<br> 
If I hit Preview, which is a cake task I defined, it runs the cake watch and review in Code.<br>
![alt](../images/CakeVSCode/CakeOptions.png)<br>
I can then see the task run every time I save and go and check the Wyam hosted blog on localhost.<br>
![alt](../images/CakeVSCode/CakeReview.png)<br>
<br>
If I wanted to, I could probably have a launch browser task in Cake and have it launch to the blog URL...<br>
Something to think about for later. <br>
<br>
Cheers<br>
Paul