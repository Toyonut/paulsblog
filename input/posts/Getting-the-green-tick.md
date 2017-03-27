Title: Getting the Green Tick
Published: 25/02/2017
Tags:
    -Azure
    -SSL
---
### Getting the Green Tick

<p>How to avoid the grey circle of indifference</p>

<p>Azure provides you a free ssl cert if you are using their webapp. 
I am guessing it is mostly for securing access to tools like Kudu and the App service editor.
It is pretty handy nonetheless for testing before you commit to buying a domain and SSL cert.</p>

If you want to use it right now with the default azurewebsites.net domain, you can.<br>
<br>
Alternatively, if you have a domain and certificate, you can use the same method to redirect browsers to https.<br>
This works because Azure webapps have [URL-Rewrite](https://www.iis.net/learn/extensions/url-rewrite-module/url-rewrite-module-configuration-reference) enabled.<br>

You can add this to your web.config and it will be applied to the webapp.<br>
There are plenty of blogs around which can help, but I followed this one from [Technet](https://blogs.technet.microsoft.com/dawiese/2016/06/07/redirect-from-http-to-https-using-the-iis-url-rewrite-module/).<br>
```<rule name="Redirect to https">
          <match url="(.*)"/>
            <conditions>
              <add input="{HTTPS}" pattern="Off"/>
            </conditions>
            <action type="Redirect" url="https://{HTTP_HOST}/{R:1}" redirectType="Permanent" />
        </rule>```