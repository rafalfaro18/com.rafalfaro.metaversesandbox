# MetaverseSandbox Core

Core Unity package to create Environments and Environment Bundles DLCs for the MetaverseSandbox Base Game of which the source code isn't public just the binary.

## Setup Steps

- Install this package into a new Unity project with below dependencies. You can just uncompress inside ``Packages`` folder or in the same location attach to your git repository as a git submodule, both methods will result in a Unity bundled package.
 

## Dependencies

- com.unity.addressables 1.19.19
- com.unity.render-pipelines.universal 12.1.11
- Unity 2021.3.25f1

## Creating Remote Catalogs
1. You only need same versions of: com.unity.addressables and Unity.
2. After installing same versions of everything create a folder for your environments bundle and mark it as addressable this will make everythig inside also addressable.
3. Inside the bundle folder create an EnvironmentsScriptableObject and all of the Environments you'll create in step 5.
4. You need to create a folder per environment.
5. Inside of each environment folder create at minimum this: A Scene and an EnvironmentScriptableObject (in this one paste the Addressable path of the Environment scene into the field called ``Environment Addessable Scene`` ).
6. After creating all of your environments build your addressables catalog and host it somewhere in the web.
7. Run the base game (you don't have to recompile) and do the Set Up Steps 4-6 again  In the quantum Console (press Esc) you should see log messages that you downloaded succesfully the new catalog.

## Hosting the Environment Bundles

### Locally for Testing
Using NPM (which comes with NODEJS) in a terminal window navigate to ``ServerData`` folder and run:
``sh
npx http-server
``
This command will start a web server in port 8080 in your local machine.


## Loading an Environment Bundle created using this package

1. Grab a legal copy of the MetaverseSandbox base game build binary (not the source code).
2. Start the game. The game build will automatically load the Lobby scene which comes bundled with the base game. Press ``Esc`` to load the QUantum Console.
3. In the Quantum Console type: ``UnloadCurrentScene`` and hit enter.
4. In the Quantum Console type: ``DownloadRemoteCatalog http://127.0.0.1:8080 catalog_2023.06.05.01.56.56.json`` and hit enter but replace `` http://127.0.0.1:8080`` for your web hosting address where you previously uploaded the contents of your new Unity Project's Addressables bake/build result (folder ``ServerData``) and the name of the catalog.json file for yours.


## To Do
- Add common prefabs that can be loaded by the base game for specific supported behaviors.
- Add networking support