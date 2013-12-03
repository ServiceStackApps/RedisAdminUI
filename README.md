[Join the new Google+ Community](https://plus.google.com/u/0/communities/112445368900682590445) or
follow [@ServiceStack](http://twitter.com/servicestack)
for twitter updates.

#ServiceStack Redis Web Services including the Redis Admin UI
Included is a ServiceStack web service layer which provide JSON, XML, JSV and SOAP 1.1/1.2 for all of Redis operations.
Just like the RedisAdminUI this allows you to fully manage your redis-server instance using javascript from a browser.

##Live Demo
A live demo of the RedisAdminUI can be found here [http://mono.servicestack.net/RedisAdminUI/AjaxClient/](http://mono.servicestack.net/RedisAdminUI/AjaxClient/)

[![Demo Screenshot](http://mono.servicestack.net/img/redisadmin-01.png)](http://mono.servicestack.net/RedisAdminUI/AjaxClient)

View the demos live list of the [available web services](http://mono.servicestack.net/RedisAdminUI/redis/metadata).

[![API Screenshot](http://mono.servicestack.net/img/redisadmin-02.png)](http://mono.servicestack.net/RedisAdminUI/redis/metadata)

#Download
[ServiceStack.RedisWebServices/downloads](https://github.com/ServiceStackV3/ServiceStack.RedisWebServices/downloads)

##Troubleshooting
Note: if running via XSP you will want to change the 'DefaultRedirectPath' to:

    <add key="DefaultRedirectPath" value="AjaxClient/default.htm"/>
