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
            def msbuildHome = tool 'MSBuild'
            echo '${msbuildHome}'
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
        def msbuildHome = tool 'MSBuild'
        bat "${msbuildHome} ./src/Cobweb.sln /p:Configuration=Release"
      }
    }
  }
}
