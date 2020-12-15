pushd swagger-codegen
mvn clean package
java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate -i https://teamcity.jetbrains.com/app/rest/swagger.json -l csharp -DpackageName=TeamCity --model-name-suffix Dto -o ./../generated
popd