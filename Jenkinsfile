pipeline {
  agent any
  stages {
    stage('NuGet Restore') {
      parallel {
        stage('NuGet Restore') {
          steps {
            powershell 'nuget restore ./src/Cobweb.sln'
          }
        }
        stage('') {
          steps {
            echo '${ tool \'MSBuild\'}'
          }
        }
      }
    }
    stage('error') {
      steps {
        bat '${tool \'MSBuild\'} ./src/Cobweb.sln /p:Configuration=Release'
      }
    }
  }
}