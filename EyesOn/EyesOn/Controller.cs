using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

using EyesOn.Data.Model.Server;
using EyesOn.Data.Model.Requests;

namespace EyesOn
{
    public class Controller
    {
        #region Singleton

        private static readonly Lazy<Controller> _Instance = new Lazy<Controller>(() => new Controller());

        private Controller()
        {
        }

        public static Controller Instance
        {
            get
            {
                return _Instance.Value;
            }
        }

        #endregion

        #region Events & Delegates

        //application events
        public static event Action OnLoad;
        public static event Action OnExit;

        //views
        public static event Action OnLogin;
        public static event Action OnMain;
        public static event Action OnCameraPreview;
        public static event Action OnCameraControl;
        public static event Action OnCameraCalibration;
        public static event Action OnColorBlobDetection;
        public static event Action OnTakePhoto;

        //view actions

        //events which spawn actions on an existing view, such as updating the temp on the thermostat, updating forecast, etc.

        //errors
        public static event Action<string> OnException;

        #endregion

        #region Public Static Methods

        //exit command
        public static void Exit()
        {
            if (null != Controller.OnExit)
            {
                OnExit();
            }
        }

        #endregion

        #region Methods

        // public methods should only deal in View Models

        //on init we should register pointer to platform-specific interfaces
        public void Init()
        {
            if (OnLoad != null)
            {
                //selectedTab = selectedTab != DisplayTab.Budget ? selectedTab : DisplayTab.Budget;
                OnLoad();
            }
        }

        public void Loaded()
        {
            //load login screen
            //if (null != OnLogin)
            //{
            //    OnLogin();
            //}

            OnMain();
        }

        public async void Thermostat()
        {
            //if (selectedTab == DisplayTab.Thermostat && OnThermostat != null)
            //{           //Jilt:prevents pull request when it's not visible

            //    var view = new ViewModel.ThermostatView();

            //    string url = "http://water.energybill.com/api/settings";

            //    try
            //    {
            //        string json = await Net.JsonRequest(url, null);
            //        var data = JsonConvert.DeserializeObject<ThermostatData>(json);

            //        data.TempWater = (data.TempWater * 1.8) + 32.0;
            //        data.TempAir = (data.TempAir * 1.8) + 32.0;
            //        data.TempSetpoint = (data.TempSetpoint * 1.8) + 32.0;

            //        view.ThermostatData = data;

            //        OnThermostat(view);
            //    }
            //    catch (WebException ex)
            //    {
            //        int temp = 1;
            //    }
            //}
        }

        /// <summary>
        /// This action will be triggered from Thermostat widget when the user drags the yellow pointer on circumference
        /// or selects new temperature by up/down buttons
        /// </summary>
        public static void SetThermostatTemperature(double temperatureValue)
        {
            double C = (temperatureValue - 32.0) / 1.8;
            string url = string.Format("http://water.energybill.com/api/setpoint?TempSetpoint={0}", C);

            try
            {
                Net.JsonRequest(url, null);
                //var data = JsonConvert.DeserializeObject<Model.ThermostatData>(json);
            }
            catch (WebException)
            {
            }
        }

        /// <summary>
        /// This action will be triggered from Budget widget when user clicks +/- 5% buttons
        /// </summary>
        public static void ChangeBudget(double percentChangeValue)
        {
            // todo
        }

        private User _CurrentUser = null;
        public User CurrentUser
        {
            get
            {
                return _CurrentUser;
            }
        }

        public async Task Login(UserCredentials credentials)
        {
            if (credentials == null) return;

            if (credentials.Email == null || credentials.Email.Length == 0) return;

            //verify user with API
            string url = "http://eyeson.easyday.net/api/login";

            try
            {
                var request = new LoginRequest()
                {
                    Id = Guid.NewGuid(),
                    Credentials = credentials
                };
                string json = await Net.JsonRequest(url, request);
                var response = JsonConvert.DeserializeObject<LoginResult>(json);

                //create user
                if (!response.Result)
                {
                    //display error
                    return;                    
                }
                else
                {
                    _CurrentUser = response.User;
                }
            }
            catch (WebException ex)
            {
                var response = ex.Response;

                string myresult;
                using (var s = new StreamReader(response.GetResponseStream()))
                {
                    myresult = s.ReadToEnd();
                }

                return;
            }

            //go to app Main
            Main();
        }

        public async void Main()
        {
            if(OnMain != null)
            {
                OnMain();
            }
        }

        public async void CameraPreview()
        {
            if (OnCameraPreview != null)
            {
                OnCameraPreview();
            }
        }

        public async void CameraControl()
        {
            if (OnCameraControl != null)
            {
                OnCameraControl();
            }
        }

        public async void CameraCalibration()
        {
            if (OnCameraCalibration != null)
            {
                OnCameraCalibration();
            }
        }

        public async void ColorBlobDetection()
        {
            if (OnColorBlobDetection != null)
            {
                OnColorBlobDetection();
            }
        }

        public async void TakePhoto()
        {
            if (OnTakePhoto != null)
            {
                OnTakePhoto();
            }
        }           

        #endregion
    }
}
