# GhostBot
  The GhostBot Application was designed to send a message to a Slack Channel when a Skype IM is received and keep a user's computer from auto-locking due to inactivity. 
  GhostBot will periodically take a screenshot of the user's Primary Monitor and scan it to see if the Skype IM icon is indicating that an IM was received; it will also force a slight mouse movement to prevent auto-locking.
  If GhostBot determines that an IM was received, it then sends a message to the SlackAPI, using a user configured Slack Channel URL, to let the user know that Skype messages were received.
