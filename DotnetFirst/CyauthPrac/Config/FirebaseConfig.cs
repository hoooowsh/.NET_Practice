//using Firebase.Auth;
//using Firebase.Auth.Providers;
//using System;
//using System.Threading.Tasks;

//public class FirebaseConfig
//{
//    private static FirebaseAuthProvider _authProvider;

//    public static FirebaseAuthProvider AuthProvider
//    {
//        get
//        {
//            if (_authProvider == null)
//            {
//                _authProvider = new FirebaseAuthProvider(FirebaseAuthConfig("AIzaSyAXKQF1amLNEe6nCPn_o3xcX9d9dL-H9II"));
//            }
//            return _authProvider;
//        }
//    }

//    public string V { get; }

//    public static async Task<FirebaseAuthLink> SignUpUser(string email, string password)
//    {
//        var auth = await AuthProvider.CreateUserWithEmailAndPasswordAsync(email, password);
//        return auth;
//    }

//    public static async Task<FirebaseAuthLink> SignInUser(string email, string password)
//    {
//        try
//        {
//            var auth = await AuthProvider.SignInWithEmailAndPasswordAsync(email, password);
//            return auth;
//        }
//        catch (FirebaseAuthException e)
//        {
//            Console.WriteLine($"Failed to sign in user: {e.Message}");
//            return null;
//        }
//    }
//}
