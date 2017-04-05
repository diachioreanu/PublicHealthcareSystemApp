var MedicalHistoryCtrl = function ($scope) {
	$scope.hello = 'salut';
	$scope.users = [{ Afectiune: 'af1', Tratament: 21, Data: '01/01/2017', Observatii: 'obs1' },
		{ Afectiune: 'af2', Tratament: 21, Data: '01/01/2017', Observatii: 'obs2' },
		{ Afectiune: 'af3', Tratament: 21, Data: '01/01/2017', Observatii: 'obs3' },
		{ Afectiune: 'af4', Tratament: 21, Data: '01/01/2017', Observatii: 'obs4' },
		{ Afectiune: 'af5', Tratament: 21, Data: '01/01/2017', Observatii: 'obs5' },
		{ Afectiune: 'af6', Tratament: 21, Data: '01/01/2017', Observatii: 'obs6' },
		{ Afectiune: 'af7', Tratament: 21, Data: '01/01/2017', Observatii: 'obs7' }];

	$scope.gridOptions = {
		data: $scope.users,
		enableFiltering: true,
		paginationPageSizes: [5, 10, 25],
		paginationPageSize: 5
	};
}
MedicalHistoryCtrl.$inject = ['$scope'];