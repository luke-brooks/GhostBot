# GhostBot
  The GhostBot is a Windows desktop application that was designed to send a message to a Slack Channel when a Skype IM is received on the user's computer and prevent the computer from auto-locking due to inactivity. 
  GhostBot will periodically take a screenshot of the user's Primary Monitor and scan it to see if the Skype IM icon is indicating that an IM was received; it will also force a slight mouse movement to prevent auto-locking.
  If GhostBot determines that an IM was received, it then sends a message to the SlackAPI, using a user configured Slack Channel URL, to let the user know that Skype messages were received.


A detailed User Guide with screenshots of application install can be found here: [https://github.com/luke-brooks/GhostBot/tree/master/GhostBotApp/User%20Guide]
