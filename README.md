# Spotify Control Center
A project to combine multiple Spotify APIs into a service for complete control over the client without the hassle of libspotify.

### Adapters for the following services

- spotifyWebHelper.exe
- Spotify meta-data API

# Supported actions

## Control the desktop client

###Play track
Play the track
###Play track from defined position
Start playback at defined minute position
###Pause
Pause playback
###Resume
Resume playback
###Get status
Return client status. Includes current track, album,artist,volume,position and allot more.
###Client version
Get client version for compatibility check.

## Metadata actions

###Get information about specific track. Including artists and album.
Returns all data about the track from spotifys database.
