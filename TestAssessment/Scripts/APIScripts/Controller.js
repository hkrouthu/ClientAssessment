app.controller('APIController', function ($scope, APIService) {
    getAll();
    function getAll() {
        var servCall = APIService.getTrainings();
        servCall.then(function (d) {
            $scope.training = d;
        }, function (error) {
            console.log('Oops! Something went wrong while fetching the data.');
        });
    }
    $scope.saveTraings = function () {
        var date1 = new Date($scope.startdate);
        var date2 = new Date($scope.enddate);

        if (date1 > date2) {
            alert('Start date should be less than End date.');
            return;
        }
        // To calculate the time difference of two dates 
        var Difference_In_Time = date2.getTime() - date1.getTime();

        // To calculate the no. of days between two dates 
        var Difference_In_Days = Difference_In_Time / (1000 * 3600 * 24);
        var training = {
            TrainingName: $scope.trainingname,
            StartDate: $scope.startdate,
            EndDate: $scope.enddate
        };
        var saveTrains = APIService.saveTraining(training);
        saveTrains.then(function (d) {
            getAll();
            alert('Successfully Saved and days difference is ' + Difference_In_Days);
        }, function (error) {
            console.log('Oops! Something went wrong while saving the data.');
        });
    }
   
});