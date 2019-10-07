# ARvision

AR Vision for Magic Leap. 

## Project setup

Open the new project in Unity.

### Setup for Magic Leap

Setup the right certificate :

* Edit > Project Settings... > Player > MagicLeap - Publishing Settings
* Set ***ML certificate*** to the path of the key

Import Magic Leap package :

* _Assets > Import package > custom package..._
* Choose the Magic Leap Unity package (Installed with Magic Leap Package manager)
* "API Update required: : click ***I made a backup. Go Ahead!***
* In _Hierachy_ tag, delete *Main camera*
* In /Assets/MagicLeap/Core/Prefabs, drag and drop the MagicLeap ***Main camera***

## Build

* _File > Build Settings_
* Click ***Build*** to get an installable MPK OR ***Build and Run*** if Magic Leap is connected

## Notes

Working with Unity **2019.2.6f1**

* Build and deploy succesfully into Magic Leap One
* Magic Leap Remote working


