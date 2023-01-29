# MastoGraph

Simple tool that visualizes threads of Mastodon Toots, based on Blazor Webassembly. 

This tool uses the Library [Mastonet](https://github.com/glacasa/Mastonet) to load a toot including it's context
and display the thread in a forum-like structure for better readability. You are also able to log into your 
Mastodon instance to get private toots of people you follow, but this only works with threads from your own instance
and I don't know how to change that or if it is even possible. 

Styling is done with [Bulma](Bulma.io) and [Feather Icons](https://feathericons.com). 

Every referenced library is under MIT License, hence this tools is too bc I like MIT, use this Software for good etc..

Mastograph is currently running on my Website [mastograph.miawinter.de](https://mastograph.miawinter.de/)

## Current Features

- Get a toot from a URL 
- Display toot and all replies to it
- nest replies beneth each other
- Hide toot button to collapse a branch 
- Logging in via OAuth2 
- PWA Support

### Supported types:

- Standard Post
- Post with Content Warning 
- Post with Media, inkluding Image, Gif, Video and Audio (audio untested)
- Post with sensitive Media 

# Missing Features

- Posts with Polls are currently not supported
- Button to hide Profile pictures (Megathread mode)
- Better horizontal scrollability (Bulma really doesn't like that one)
- Figure out how custom emojis work 
- Maybe: Honor the users "Hide Media by default" setting if they are logged in or make it a 
setting in the app itself
