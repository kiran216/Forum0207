app.controller("categoryController", ['$scope',  'categoryService', 
function categoryController($scope, categoryService) {
    $scope.status;
    $Scope.CategoriesList
      categoryService.GetcategoryList()
            .then(function (response) {
                $scope.CategoriesList = response.data;
            }, function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
            });
      $scope.gridOptions = { data: $scope.CategoriesList };

    $scope.message = 'test';
}]);
