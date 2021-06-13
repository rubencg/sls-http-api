declare -a function_directories=("Todo.Get")

dotnet restore

echo "Building every project"
for dir in "${function_directories[@]}"
do
  cd "$dir" || exit
  echo "$PWD"
  dotnet lambda package --configuration Release --framework netcoreapp3.1 --output-package bin/Release/netcoreapp3.1/build.zip
done