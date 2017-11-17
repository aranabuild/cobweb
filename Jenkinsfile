pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat "\"${tool name: 'MSBuild', type: 'msbuild'}msbuild.exe\" ./src/Cobweb.sln /p:Configuration=Release"
      }
    }
  }
}
