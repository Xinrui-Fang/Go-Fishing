# Go-Fishing
AR capstone project for M1 spring semester

## Setup Environment
* Windows 10
* Unity 2019.2.17f
* Vuforia 9.2.4

## Introduction
In this project, we proposed a fishing MR application to take fishing lovers immersive fishing experience. Educational purpose is granted also, users can learn fish specie introduction, fishing tricks and tips in this application. Moreover, we designed a complete UI interactive system based on user experience design.
<img src="https://github.com/Xinrui-Fang/Go-Fishing/blob/master/img/Playing.png" width = "500"  alt="" align=center /><br/>


## Background
Fishing is a popular sports in Japan and even all over the world. However, due to current condition, a lot of fishing lovers can not go fishing as usual because of travelling restriction. In order to solve this problem, we proposed this Mixed Reality Fishing application for fishing lovers to use during this special time.

Users can enjoy fishing experience at anywhere, 15 different fish models will be generated in the game, and fishing spices knowledge, tricks and tips are introduced in the game. On the one hand, users can get immersive fishing experience in the game, on the other hand, they can get more knowledge about their hobbies. 

## Implementation
In this section, I will introduce implementation details below, including physical prototype and AR system.

### Physical Prototype
For the purpose of granting users immersive fishing experience, we mixed the fishing rod and smartphone together, as shown in Figure 1. Users can place the smart phone horizontally at the smart phone holder on the fishing rod. Simultaneously, cylinder target is implemented as fishing lure. We tried a lot AR target before, cylinder target is the most suitable for this project due to the contribution of rotation non-sensitive. On the contrary, image target is only suitable on the ground plane, and object target can only be tracked at specific angles. Once we install the cylinder target to the fishing rod, fishing reel is facilitated to control the movement of cylinder target. When cylinder target is put down and can be detectable by the camera, the virtual fishing models will be generated on the cylinder target.   
<img src="https://github.com/Xinrui-Fang/Go-Fishing/blob/master/img/Fishing%20reel.jpg" width = "500"  alt="" align=center /><br/>


### Game Design
Default target tracking scripts offered by Vuforia can only generate one object above the target. However, we propose to generate 15 different kinds of fish in our scenarios, so we change default target tracking scripts to satisfy our demand. Two parts of code mainly modified, first part is OnTrackingFound() function, we change the code that let the Vuforia generate a random fish model once the target is tracked. Secondly, we change the content of OnTrackingLost() function, once the target is lost, the fish model game object will be destroyed simultaneously. 

## Wireframe
he wireframe of our whole application is attached as appendix in the last page. I will introduce each screen page separately below:
* Main Page: There is three button on the main page, when users click 'PLAY' button, the scene will jump to Vuforia Game page; when users click 'Pamphlet' button, the scene will switch to pamphlet page; when users click 'QUIT' button, the game will be quit. 
* Game Page: In the game page, users can use fishing rod prototype and cylinder target to generate different fish models. When target is tracked and fish model is generated, users can click left up fish button to check the introduction of this fish specie. Users can also click right up button to return to the main page.
* Pamphlet: Once one kind of fish is generated in Game Page, the icon of this fish is activated in Pamphlet page, users can click on each fish icon to check their fishing tricks and tips videos. Of course, users can click return button to return to the main page.
* Video Player: Video Player can be activated on pamphlet page, fishing tricks and tips video will be played on this page, user can click 'Play and Pause' button to pause or start the video, and they can also return back to the pamphlet page with 'Close' button.
<img src="https://github.com/Xinrui-Fang/Go-Fishing/blob/master/img/Wireframe.jpg" width = "500"  alt="" align=center /><br/>
