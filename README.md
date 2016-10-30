# PluginSDK
This is a SDK for developing plugins for [MultiDesktop](http://altomizemedia.servehttp.com/MultiDesktop/). All plugins will implement *IPlugin* interface which will allow the plugin author to specify their name, plugin name, and version to be used in About page of MultiDesktop. While there is no restriction for plugin author to use consistent case sensitive name for their plugins, it is highly recommended to do. Please study all the interfaces to determine what interface your plugin should implement.

To allow MultiDesktop to properly load the plugin, carefully edit `MultiDesktop.exe.config` in the following way. Under plugins tags for each plugin, make a new plugin tag in the following manner: 

`<plugin name="<namespace>.<class name>, <project name>" type="<plugin type>"/>`

Replace `<namespace>` with your project namespace and `<project name>` with the same name you named your project. Replace `<plugin type>` with the name of the plugin interface you implemented and replace `<class name>` with the main class that implement that interface.
