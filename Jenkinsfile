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
        stage('Print') {
          steps {
            echo '${ tool \'MSBuild\'}'
          }
        }
        stage('Tool') {
          steps {
            tool 'MSBuild'
          }
        }
      }
    }
    stage('Build') {
      steps {
        bat '${tool \'MSBuild\'} ./src/Cobweb.sln /p:Configuration=Release'
      }
    }
  }
}