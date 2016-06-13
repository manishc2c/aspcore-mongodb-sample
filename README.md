# ASP.NET Core 1.0 and MongoDB Sample Application
This is MongoDB Example Application which demonstrate connectivity between ASP.NET Core 1.0 and MongoDB on OpenShift 3 Cloud.

## How to run this sample on OpenShift 3
1) To run this sample application on OpenShift 3 Environment, deploy Click2Cloud's ASP.NET Templates on OpenShift 3 environment as specified instructions at https://github.com/Click2Cloud/DotNetOnOpenShift3.

Once ASP.NET Templates availble in OpenShift Web Console, create application using `aspnetcore-mongodb-ex` template and provide this as a source repository url.

2) Once application comes in running state, its time to update connectionstring of MongoDB in `ConnectionSetting.cs` file. Based on MongoDB pod created in OpenShift update `mongoDBClusterIP` variable in `ConnectionSetting.cs` file.

##### NOTE: Use `mongodb` pod `Cluster IP` as a `mongoDBClusterIP` value in `ConnectionSetting.cs` and commit changes in GitHub.

Now rebuild application again on OpenShift 3 to modify MongoDB Connection settings.
