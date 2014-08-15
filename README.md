[Join the new Google+ Community](https://plus.google.com/u/0/communities/112445368900682590445) or
follow [@ServiceStack](http://twitter.com/servicestack)
for twitter updates.

## ServiceStack Redis Web Services including the Redis Admin UI

Included is a ServiceStack web service layer which provide JSON, XML, JSV and SOAP 1.1/1.2 for all of Redis operations. Just like the RedisAdminUI this allows you to fully manage your redis-server instance using javascript from a browser.

## Live Demo

A live demo of the RedisAdminUI can be found here [http://redisadminui.servicestack.net/AjaxClient/](http://mono.servicestack.net/RedisAdminUI/AjaxClient/)

[![Demo Screenshot](https://github.com/ServiceStack/Assets/blob/master/img/apps/RedisAdminUI/home.png)](http://redisadminui.servicestack.net/AjaxClient)

View the demos live list of the [available web services](http://redisadminui.servicestack.net/redis/metadata).

[![API Screenshot](Demo Screenshot](https://github.com/ServiceStack/Assets/blob/master/img/apps/RedisAdminUI/metadata.png)](http://redisadminui.servicestack.net/redis/metadata)

## Troubleshooting

Note: if running via XSP you will want to change the 'DefaultRedirectPath' to:

    <add key="DefaultRedirectPath" value="AjaxClient/default.htm"/>
