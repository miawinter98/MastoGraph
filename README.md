# MastoGraph

Simple tool that visualizes threads of Mastodon Toots, based on Blazor Webassembly. 

This tool uses the Library [Mastonet](https://github.com/glacasa/Mastonet) to load a toot including it's context
and display the thread in a forum-like structure for better readability. You are also able to log into your 
Mastodon instance to get private toots of people you follow, but this only works with threads from your own instance
and I don't know how to change that or if it is even possible. 

Styling is done with [Bulma](Bulma.io) and [Feather Icons](https://feathericons.com). 

Every referenced library is under MIT License, hence this tools is too bc I like MIT.

# Missing Features

- Polls are currently not displayed
- Button to hide Profile picutres (Megathread mode)
- Better horizontal scrollability (Bulma really doesn't like that one)
- Maybe: Honor the users "Hide Media by default" setting if they are logged in or make it a 
setting in the app itself
