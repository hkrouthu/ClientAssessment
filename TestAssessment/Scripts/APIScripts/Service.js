app.service("APIService", function ($http) {
    this.getTrainings = function () {
        var url = 'api/Training';
        return $http.get(url).then(function (response) {
            return response.data;
        });
    };
    this.saveTraining = function (training) {
        return $http({
            method: 'post',
            data: training,
            url: 'api/Training'
        });
    };
});