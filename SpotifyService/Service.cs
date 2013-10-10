using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpotifyLocalApi;

namespace SpotifyService
{
    public class Service
    {
        private SpotifyLocalApi.API localAPI;
        private SpotifyMetaDataAPI.API metaAPI;
        
        public Service() {
            setupLocalApi();
            setupMetaApi();
        }

        public SpotifyMetaDataAPI.Track  getTrackInfo(string trackUri) {
            return metaAPI.getTrackInfo(trackUri);
        }

        public SpotifyLocalApi.Status play(string uri,string startingPosition){
            localAPI.URI = uri+"%23"+startingPosition;
            return localAPI.Play;
        }
        public SpotifyLocalApi.Status play(string uri) {
           return this.play(uri,"0:0");
        }

        public SpotifyLocalApi.Status pause() {
            return localAPI.Pause;
        }

        public SpotifyLocalApi.Status resume() {
            return localAPI.Resume;
        }

        public SpotifyLocalApi.Status getStatus() {
            return localAPI.Status;
        }

        public SpotifyLocalApi.ClientVersion ClientVersion() {
            return localAPI.ClientVersion;
        }
        
        public void setupLocalApi() {
            localAPI = new SpotifyLocalApi.API(SpotifyLocalApi.API.GetOAuth(), "awesome.spotilocal.com");
            CFID cfid = localAPI.CFID; //It's required to get the contents of API.CFID before doing anything, even if you're not intending to do anything with the CFID
            if (cfid.error != null)
            {
                Console.WriteLine(string.Format("Spotify returned a error {0} (0x{1})", cfid.error.message, cfid.error.type));
            }
            Status Current_Status = localAPI.Status;
            if (cfid.error != null)
            {
                Console.WriteLine(string.Format("Spotify returned a error {0} (0x{1})", cfid.error.message, cfid.error.type));
            }
        }

        public void setupMetaApi() {
            metaAPI = new SpotifyMetaDataAPI.API();
           
        }
 
    }
}
