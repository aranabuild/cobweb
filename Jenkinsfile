pipeline {
  agent any
  tools {
    msbuild 'MSBuild'
  }
  stages {
    stage('NuGet Restore') {
      stage('NuGet Restore') {
        steps {
          powershell 'nuget restore ./src/Cobweb.sln'
        }
      }
    }
    stage('Build') {
      steps {
        bat "msbuild.exe ./src/Cobweb.sln /p:Configuration=Release"
      }
    }
  }
}
