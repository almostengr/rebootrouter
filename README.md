# Reboot Router 

Reboots the DD-WRT router when there are no WiFi clients connected to it.

## Background 

My router would occasionally disconnect any of the wireless clients that were connected to it. Since 
I have wired and wireless devices connected, some of the time I would not know that the wifi had 
stopped working until my phone or laptop wouldn't connect or I noticed that a automation did not 
trigger when it should have. 

## Solution 

After updating to the latest DD-WRT firmware, the problem persisted.  Given that I work building
automations to improve business processes, I decided that I would build and automation that would 
connect to the router’s web interface and see if there are any wireless clients connected to it.  
If there are no connected wireless clients, then there is a great chance that the wifi process that 
authenticates clients has crashed.  As a result, the process would need to be restarted and the easiest way
to restart the process would be to reboot the router. 

## The Technology 
This solution uses Selenium Webdriver to connect to the DD-WRT router web interface. I built this using
Java, but it could be done on Python or one of the other platforms that Webdriver works on. 
Ialso set up a cron job that calls the jar to perform the automated task.  The cron job is set to run every 
20 minutes.  I have it set up on my media server, as the media server is always online.  However, you 
could install Java on the router and have the automation run from the router. 


## Questions 
If you have questions about this project, feel free to create an issue with your question. 

## Author

Kenny Robinson, @almostengr

[http://thealmostengineer.com](themostengineer.com)
